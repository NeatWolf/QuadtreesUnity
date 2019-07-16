﻿namespace Quadtree {

    public struct Vector2D {
        public readonly float x;
        public readonly float y;

        public Vector2D (float x, float y) {
            QuadtreeTest.AddDebugMessage ("Vector2D::Vector2D");
            this.x = x;
            this.y = y;
        }

        public override string ToString () {
            return string.Format ("({0:0.00}, {1:0.00})", x, y);
        }

        public override bool Equals (object obj) {
            QuadtreeTest.AddDebugMessage ("Vector2D::Equals");
            if (obj == null) {
                return false;
            }

            if (!GetType ().Equals (obj.GetType ())) {
                return false;
            }

            Vector2D otherVector = (Vector2D) obj;
            return x.Equals (otherVector.x) && y.Equals (otherVector.y);
        }

        public override int GetHashCode () {
            QuadtreeTest.AddDebugMessage ("Vector2D::GetHashCode");
            return (x, y).GetHashCode ();
        }

        /*
        Operator overload
         */

        public static Vector2D operator * (Vector2D vector, float number) {
            QuadtreeTest.AddDebugMessage ("Vector2D::operator *");
            return new Vector2D (vector.x * number, vector.y * number);
        }

        public static Vector2D operator / (Vector2D vector, float number) {
            QuadtreeTest.AddDebugMessage ("Vector2D::operator /");
            return new Vector2D (vector.x / number, vector.y / number);
        }

    }
}