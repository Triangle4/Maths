using System;
using UnityEngine;
namespace Maths
{
    public partial class Matha
    {
        ///<summary>Returns true if the supplied floats are approximately similar, where approximately is defined by the threshold </summary>
        public static bool Approximately (float a, float b, float threshold){
            if (a - b <= threshold)
                return true;
            return false;
        }
        ///<summary>Returns true if the supplied Vector2's are approximately similar, where approximately is defined by the threshold </summary>
        bool Approximately (Vector2 a, Vector2 b, float threshold){
            bool x = Approximately(a.x, b.x, threshold);
            bool y = Approximately(a.y, b.y, threshold);
            if(x && y)
                return true;
            return false;
        }
        ///<summary>Returns true if the supplied Vector3's are approximately similar, where approximately is defined by the threshold </summary>
        public static bool Approximately (Vector3 a, Vector3 b, float threshold){
            bool x = Approximately(a.x, b.x, threshold);
            bool y = Approximately(a.y, b.y, threshold);
            bool z = Approximately(a.z, b.z, threshold);
            if(x && y && z)
                return true;
            return false;
        }
        
        ///<summary>Returns true if the supplied Quaternions are approximately similar, where approximately is defined by the threshold </summary>
        public static bool Approximately (Quaternion a, Quaternion b, float threshold){
            bool x = Approximately(a.x, b.x, threshold);
            bool y = Approximately(a.y, b.y, threshold);
            bool z = Approximately(a.z, b.z, threshold);
            if(x && y && z)
                return true;
            return false;
        }
        ///<summary>Experimental, unfinished </summary>
        public static bool WithinTheConfinesOf(Transform t, Bounds b){            
            if(t.position.x < b.max.x && t.position.x > b.min.x)
                if(t.position.y < b.max.y && t.position.y > b.min.y)
                    if(t.position.z < b.max.z && t.position.z > b.min.z)
                        return true;
            return false;
        }
        
        ///<summary>Returns a down-rounded integer of value n</summary>
        public static int FloorToInt(float n)
        {
            return n > 0 ? (int)(n - n % 1) : (int)(n - (n % -1));
        }
        ///<summary>Returns a down-rounded Vector3Int of value </summary>
        public static Vector3Int FloorToInt(Vector3 v)
        {
            return new Vector3Int(FloorToInt(v.x), FloorToInt(v.y), FloorToInt(v.z));   
        }
        ///<summary>Returns the largest int of two ints</summary>
        public static int Largest(int a, int b)
        {
            return a > b ? a : b;
        }
        ///<summary>Returns the largest float of two floats</summary>
        public static float Largest(float a, float b)
        {
            return a > b ? a : b;
        }
       ///<summary>Returns the smallest int of two ints</summary>
        public static int Smallest(int a, int b)
        {
            return a < b ? a : b;
        }
        ///<summary>Returns the smallest float of two floats</summary>
        public static float Smallest(float a, float b)
        {
            return a < b ? a : b;
        }
        
        ///<summary>Returns the absolute value of value n</summary>
        public static int Abs(int n)
        {
            return n > 0 ? n: n* -1;
        }
        ///<summary>Returns the absolute float of value n</summary>
        public static float Abs(float n)
        {
            return n > 0 ? n : n * -1;
        }
        ///<summary>Returns the absolute Vector3 of a n</summary>
        public static Vector3 Abs(Vector3 n){
            return new Vector3(n.x < 0 ? n.x *= -1 : n.x, n.y < 0 ? n.y *= -1 : n.y, n.z < 0 ? n.z *= -1 : n.z);
        }
        ///<summary>Returns the absolute Vector3Int of a n</summary>
        public static Vector3Int Abs(Vector3Int n){
            return new Vector3Int(n.x < 0 ? n.x *= -1 : n.x, n.y < 0 ? n.y *= -1 : n.y, n.z < 0 ? n.z *= -1 : n.z);
        }
    }    
}
[System.Serializable]
public class MinMax{
    public float min{get; private set;}
    public float max{get; private set;}

    ///<summary> Creates a new MinMax with the default values of 0 for min, and 1 for max </summary>
    public MinMax(){
        this.min = 0;
        this.max = 1;
    }
    ///<summary> Creates a new MinMax with the specified Min and Max values </summary>
    public MinMax(float min, float max){
        this.min = min;
        this.max = max;
    }
    ///<summary> Updates the MinMax with the specified Min and Max values </summary>
    public void UpdateMinMax(float min, float max){
        this.min = min;
        this.max = max;
    }
}