using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alphaInsertBook : MonoBehaviour
{

    public string inputBookTitle;
    public string inputBookAuthor;
    public string inputBookPublisher;
    public string inputBookDate;
    public string inputBookAcquiredDate;
    public string inputBookDonator;
    public string inputBookLostDate;
    public string inputBookCondition;

    string alphaInsertBookPHP = "http://localhost/alpha/alphaInsertBook.php";

	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            createBook(inputBookTitle, inputBookAuthor, inputBookPublisher,
                       inputBookDate, inputBookAcquiredDate, inputBookDonator,
                       inputBookLostDate, inputBookCondition);
        }
    }


    public void createBook(string title, string author, string publisher,
                           string date, string acquiredDate, string donator,
                           string lostDate, string condition)
    {
        WWWForm form = new WWWForm();

        form.AddField("bookTitleHere", title);
        form.AddField("bookAuthorHere", author);
        form.AddField("bookPublisherHere", publisher);
        form.AddField("bookDateHere", date);
        form.AddField("bookAcquiredDateHere", acquiredDate);
        form.AddField("bookDonatorHere", donator);
        form.AddField("bookLostDateHere", lostDate);
        form.AddField("bookConditionHere", condition);

        WWW www = new WWW(alphaInsertBookPHP, form);
    }
}
