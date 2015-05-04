﻿using System.Drawing;

namespace MW5.Api.Interfaces
{
    public interface IEnvelope: IComWrapper
    {
        double MinX { get; }
        double MinY { get; }
        double MinZ { get; }
        double MinM { get; }
        double MaxX { get; }
        double MaxY { get; }
        double MaxZ { get; }
        double MaxM { get; }
        Rectangle ToRectangle();
        void SetBounds(double xMin, double xMax, double yMin, double yMax);
        IEnvelope Move(double dx, double dy);
        double Width { get; }
        double Height { get; }
        ICoordinate Center { get; }
        IEnvelope Adjust(double xyRatio);
        bool PointWithin(double x, double y);
        IEnvelope Inflate(double dx, double dy);
        void Union(IEnvelope env);
    }
}
