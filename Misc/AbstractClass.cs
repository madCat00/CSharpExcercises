abstract class Meter{
    public abstract double speed();
}
class ItalianMeter : Meter{
    int space;
    int time;

    public ItalianMeter(int Space,int Time)
    {
            this.space = Space;
            this.time = Time;
    }

    public override double speed()
    {
        double speed;
        double convertSpace = (space)*3.6; //km
        speed = (convertSpace/time);
        return speed;
   }
}
 
class englishMeter : Meter 
{
    double space;
    double time;

    public englishMeter(double Space,double Time)
    {
        this.space = Space;
        this.time = Time;
    }
    public override double speed()
    {
        double mph = (3600/621.37);
        double convertSpace = (space * mph); //miles
        double speed = (convertSpace / time);
        return speed;

    }
}

