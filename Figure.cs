﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Input.Inking;

public class Figure
{
    private string name;
    private List<Point> points;
    public bool selected;
    //스트로크 수 (보류)

    private Rect boundingRect;
    //+시작점 +센터 + 끝점

    private float totalPressure;
    private float partPressure;

    //교차곤란
    private float standardDeviation = 0;
    private float variance = 0.0f;

    //단순화
    private IReadOnlyList<InkStroke> strokes;
    public bool is_simplification;

    public string Name
    {
        get { return name; }  set{ name = value; }
    }
    public List<Point> Points
    {
        get { return points; }  set { points = value; }
    }
    public Rect BoundingRect
    {
        get { return boundingRect; }
        set { boundingRect = value; }
    }
    public float StandardDeviation
    {
        get { return standardDeviation; }
        set { standardDeviation = value; }
    }
    public float Variance
    {
        get { return variance; }
        set { variance = value; }
    }

    public IReadOnlyList<InkStroke> Strokes
    {
        get { return strokes; }
        set { strokes = value; }
    }

    public void CalPoints(IReadOnlyList<InkStroke> strokes)
    {
        points = new List<Point>();
        foreach (var stroke in strokes)
        {
            if (stroke.Selected != true)
                continue;
            var selectedPoints = stroke.GetInkPoints();

            foreach (var pt in selectedPoints)
            {
                if (points == null)
                {
                    points.Add(pt.Position);
                    continue;
                }
                if (points.Exists(p => p == pt.Position) != true)
                { 
                    points.Add(pt.Position);
                }
            }
        }
    }

    public void CalcTotalPressure(Figure f, IReadOnlyList<InkStroke> strokes)
    {
        var nTotalPoints = 0;

        foreach (var stroke in strokes)
        {
            if (stroke.Selected != true)
                continue;
            var points = stroke.GetInkPoints();

            foreach (var pt in points)
            {
                totalPressure += pt.Pressure;
            }
            nTotalPoints += points.Count;
        }
        totalPressure /= nTotalPoints;

        //text1.Text = "전체 필압의 평균 : " + pressure.ToString();
    }

    public void CalcPartPressure(Figure f, IReadOnlyList<InkStroke> strokes, Point partStartPosition, Point partLastPosition)
    {
        var nTotalPoints = 0;
        float varTemp = 0.0f;

        foreach (var stroke in strokes)
        {
            if (stroke.Selected != true)
                continue;
            var points = stroke.GetInkPoints();
            foreach (var pt in points)
            {
                if (partStartPosition.X <= pt.Position.X && partStartPosition.Y <= pt.Position.Y &&
                    partLastPosition.X >= pt.Position.X && partLastPosition.Y >= pt.Position.Y)
                {
                    partPressure += pt.Pressure;
                    varTemp += (pt.Pressure - totalPressure) * (pt.Pressure - totalPressure);//분산에 totalPressure 빼는게 맞는지 확인
                    nTotalPoints++;
                }

            }
        }
        partPressure /= nTotalPoints;//선택영역의 평균
        varTemp /= nTotalPoints;//분산
        f.variance = varTemp;
        f.standardDeviation = (float)Math.Round(Math.Sqrt(varTemp), 2);

        //text2.Text = "교차점영역 필압의 평균 : " + partPressure.ToString();
    }

}

