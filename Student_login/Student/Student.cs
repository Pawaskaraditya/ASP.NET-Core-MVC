
using System;

public class Student{
    public string Name {set;get;}
    public string Email {set;get;}
    public string Pass {set;get;}

    public Student(){}
    public Student(string name,string email,string pass){
        this.Name=name;
        this.Email=email;
        this.Pass=pass;
    }
    
}