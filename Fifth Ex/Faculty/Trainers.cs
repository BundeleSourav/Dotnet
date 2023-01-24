namespace Faculty;
using System.ComponentModel.DataAnnotations;

[Serializable]
public class Trainers
{
    public int Id{get;set;}
    [Required]
    public string FirstName{get;set;}
    // public string LastName{get;set;};
    // public string Course{get;set;};
    // public string Email{get;set;};
    // public string Gender{get;set;};
    // public int Experience{get;set;};

    public Trainers()
    {
        this.Id=10;
        this.FirstName="Sourav";
        // this.LastName="Bundele";
        // this.Course="PGDAC";
        // this.Email="hsdbahd@gmaiil.com";
        // this.Gender="Male";
        // this.Experience="11";
    }


        // ,string lname,string course,string email,string gender,int experience
    public Trainers(int id,string fname)
    {
        this.Id=id;
        this.FirstName=fname;
    }
}
