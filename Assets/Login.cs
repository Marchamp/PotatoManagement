using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour {

    public string inputUsername;
    public string inputPassword;

    string LogInURL = "http://localhost/followTutoreal/Login.php";

    
    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.L)) StartCoroutine(LoginToDB(inputUsername, inputPassword));
	}

    IEnumerator LoginToDB(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("passwordPost", password);

        WWW www = new WWW(LogInURL, form);
        yield return www;
        Debug.Log(www.text);
    }
}
