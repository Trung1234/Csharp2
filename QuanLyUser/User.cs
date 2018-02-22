using System;

namespace QuanLyUser
{

public class User 
{
    private Account acc;
   
    public User(string userName, string phone, 
        string name, string pass) {
		acc = new Account(userName, pass);
		Name = name;
		Phone = phone;

    }
    
    // properties 
    public string Name {
		get; 
		set ; 
	}
    public string Phone {
		get; 
		set ; 
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
    



	// public bool Equals(User user) {
	// 	return this.acc.UserName.Equals(user.UserName);
    // }

}
}