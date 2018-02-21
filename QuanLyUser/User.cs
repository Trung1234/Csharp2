using System;

namespace QuanLyUser
{

public class User : IComparable<User>
{
    private string name, phone;
    private Account acc;
   
    public User(string userName, string phone, 
        string name, string pass) {
		acc = new Account(userName, pass);
		this.name = name;
		this.phone = phone;

    }
    
    // properties 
    public string Name {
		get { return name; }
		set { name = value; }
	}
    public string Phone {
		get { return phone; }
		set { phone = value; }
	}
    public string UserName {
        get { return acc.UserName; }
		set { acc.UserName = value; }
    }
    public string Pass {
        get { return acc.Pass; }
		set { acc.Pass = value; }
    }
    //
    

    public int CompareTo(User other)
    {
      
        return this.Name.CompareTo(other.Name);
        
    }

	public bool Equals(User user) {
		return this.acc.UserName.Equals(user.UserName);
    }

    public override string ToString()
    {
        return acc.ToString() + "-" + Name + "-" + Phone + "\n";
    }
}
}