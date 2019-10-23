﻿using Assets.Scripts.IAJ.Unity.Utils;
using UnityEngine;
using System;

namespace Assets.Scripts.IAJ.Unity.Pathfinding.Path
{
    public class LineSegmentPath : LocalPath
    {
        protected Vector3 LineVector;
        public LineSegmentPath(Vector3 start, Vector3 end)
        {
            this.StartPosition = start;
            this.EndPosition = end;
            this.LineVector = end - start;
        }

        public override Vector3 GetPosition(float param)
        {
            return this.StartPosition + this.LineVector * param;
        }

        public override bool PathEnd(float param)
        {
            //TODO: define constant
            return param >= 0.85f;
        }

        public override float GetParam(Vector3 position, float lastParam)
        {
            //TODO: how to use lastParam
            float param = MathHelper.closestParamInLineSegmentToPoint(this.StartPosition, this.EndPosition, position);
            return param;
        }

        public override float GetOffset(float param)
        {
            return Math.Abs((this.EndPosition - this.GetPosition(param)).magnitude); 
        }
    }
}