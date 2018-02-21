

public class Account {
	private string userName, pass;

	public Account(string userName, string pass) {
		this.userName = userName;
		this.pass = pass;
	}

	public string UserName {
		get { return userName; }
		set { userName = value; }
	}

	public string Pass {
		get { return pass; }
		set { pass = value; }
	}

	public override string ToString() {
		return UserName + "-" + Pass;
	}
}