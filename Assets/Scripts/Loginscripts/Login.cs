using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour { 
    //static variables
    public static string Email = "";
    public static string Password = "";

    //public variables
    public string CurrentMenu = "Login";

    //private variables
    private string CreateAccountUrl = ""; //link to php and mysql
    private string LoginUrl = "";
    private string ConfirmPassword = ""; //confirm password
    private string ConfirmEmail = ""; //confirm email
    private string CEmail = ""; //create email
    private string CPassword = ""; //create password

    //GUI test section
    public float X;
    public float Y;
    public float Width;
    public float Height;

    

    void Start()
    {

    }

    //Main GUI functions
    void OnGUI()
    {
        if(CurrentMenu == "Login"){
            // if our current menu = login, the display the login menu by calling our logingui function. Else, display the create account gui by calling its function
            LoginGUI();
        }
        else if (CurrentMenu == "CreateAccount"){
            CreateAccountGUI();
        }
    }
    //this method will login account
    void LoginGUI()
    {   
        //create window
        GUI.Box(new Rect(280, 120, (Screen.width / 4) + 200,(Screen.height / 4) + 250), "Login");
        //create Account and login button
        
        //open Create account window
        if (GUI.Button(new Rect(370, 360, 120, 25), "Create Account")){
            CurrentMenu = "CreateAccount";
        }
        //log user in
        if(GUI.Button(new Rect(520, 360, 120, 25), "Login")){
            
        }
        //email and password login
        GUI.Label(new Rect(390, 200, 220, 23), "Email:");
        Email = GUI.TextField(new Rect(390, 225, 220, 23), Email);

        GUI.Label(new Rect(390, 250, 220, 23), "password:");
        Password = GUI.TextField(new Rect(390, 275, 220, 23), Password);
    }

    //this methot will be the GUI for creating an account
    void CreateAccountGUI()
    {
        //create window
        GUI.Box(new Rect(280, 120, (Screen.width / 4) + 200, (Screen.height / 4) + 250), "Create Account");

        //email and password and conformation create
        GUI.Label(new Rect(390, 200, 220, 23), "Email:");
        CEmail = GUI.TextField(new Rect(390, 225, 220, 23), CEmail);

        GUI.Label(new Rect(390, 250, 220, 23), "Password:");
        CPassword = GUI.TextField(new Rect(390, 275, 220, 23), CPassword);

        GUI.Label(new Rect(390, 300, 220, 23), "Confirm Email:");
        ConfirmEmail = GUI.TextField(new Rect(390, 325, 220, 23), ConfirmEmail);

        GUI.Label(new Rect(390, 350, 220, 23), "Confirm Password:");
        ConfirmPassword = GUI.TextField(new Rect(390, 375, 220, 23), ConfirmPassword);

        //create random int for evil bots

        //create Account and login button

        //open Create account window
        if (GUI.Button(new Rect(370, 460, 120, 25), "Create Account"))
        {
            if(ConfirmPassword == CPassword && ConfirmEmail == CEmail){
                StartCoroutine("CreateAccount");
            }
            else{
                //StartCoroutine();
            }
           
        }
        //back button
        if (GUI.Button(new Rect(520, 460, 120, 25), "Back"))
        {
            CurrentMenu = "Login";
        }
    }
    //actually create account
    IEnumerator CreateAccount()
    {
        //this is what sends messages to php script
        WWWForm Form = new WWWForm();
        //field is what we are sending
        Form.AddField("Email", CEmail);
        Form.AddField("Password", CPassword);

        WWW CreateAccountWWW = new WWW(CreateAccountUrl, Form);
        //wait for php to send something back
        yield return CreateAccountWWW;
        if(CreateAccountWWW.error != null){
            Debug.LogError("Cannos Connect to Account Creation");
        }
        else{
            string CreateAccountReturn = CreateAccountWWW.text;
            if(CreateAccountReturn == "Succes"){
                Debug.Log("Succes: Account created");
                CurrentMenu = "Login";
            }
        }
    }
  
}
