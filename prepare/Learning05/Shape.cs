using System;

//I do not force the class to be abstract, but all undifferentiated Shapes have an area of 0.
//If I were going to add more classes, I might build off of this for custom shapes.
class Shape {
    private string _color;
    public string getColor() {
        return _color;
    }
    public void setColor(string color) {
        _color = color;
    }
    public virtual double getArea() {
        return 0;
    }
    public Shape(string color) {
        _color = color;
    }
}