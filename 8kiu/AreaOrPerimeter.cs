/*
You are given the length and width of a 4-sided polygon. 
The polygon can either be a rectangle or a square.
If it is a square, return its area. If it is a rectangle, return its perimeter.
*/

public class MathCheck {
    public static int AreaOrPerimeter(int l, int w) {
        // code goes here
      return l == w ?  w*l : 2*l + 2*w;
    }
}