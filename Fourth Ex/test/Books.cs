namespace Library;

public class Books{
    private string[] titles;
    public Books()
    {
        titles=new string[5];

        this.titles[0]="IKIGAI";
        this.titles[1]="THE ALCHEMIST";
        this.titles[2]="THE MONK WHO SOLD HIS FERRARI";
        this.titles[3]="The Art of Subtle";
        this.titles[4]="Rich Dad,Poor Dad";
    }

    public string this[int index]{
        get{return titles[index];}
        set{titles[index]=value;}
    }
}