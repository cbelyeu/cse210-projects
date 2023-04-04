using System;

class Square : Shape {
    private double _side = 0;
    public Square(string color, int side): base(color) {
        _side = side;
    }
    public override double getArea() {
        return _side * _side;
    }
}