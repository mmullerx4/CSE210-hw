using System;

abstract class Activity //really only a parent class can be abstract
{
    private string _date;
    protected double _minutes;
    protected string _activity;


    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }


    //the base class should contain virtual methods for getting the distance, speed, pace.
    //These methods should be overridden in the derived classes.
    public abstract double GetDistance(); //abstract means put the details or formula in the derived classes
    //no body needed so use ";"
       

    public virtual double GetSpeed(){
        //Speed (mph or kph) = (distance / minutes) * 60
        return (GetDistance() / _minutes) * 60;

    }
    

    public virtual double GetPace()
    {
        //Pace (min per mile or min per km)= minutes / distance
        return _minutes / GetDistance();
    }


    //This method should be available for all classes, so it should be defined in the base class
    //(you can override it in the derived classes if needed, but it may not need to be...).
    public void GetSummery()
    {
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

        Console.WriteLine($"{_date} {_activity} ({_minutes} min.)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min. per mile");
    }
}