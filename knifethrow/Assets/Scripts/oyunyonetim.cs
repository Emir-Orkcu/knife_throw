using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunyonetim : MonoBehaviour
{
    public bool kontrol = true;
  
    GameObject donenCember;
    GameObject anaCember;
 
    public Animator animator;
    public Text leveltext;
    
    public void text2()
    {
        leveltext.text = "";
    }

    
    void Start()
    {
        PlayerPrefs.SetInt("kayıt",int.Parse(SceneManager.GetActiveScene().name));

        donenCember = GameObject.FindGameObjectWithTag("donencembertag");
        anaCember = GameObject.FindGameObjectWithTag("anakılıctag");
       
        leveltext.text = "Level"+ SceneManager.GetActiveScene().name;
        
    }

    public void OyunBitti()
    {
        StartCoroutine(OyunBittiKod());
    }
    IEnumerator OyunBittiKod()
    {
        donenCember.GetComponent<Dondurme>().enabled = false;
        anaCember.GetComponent<anacember>().enabled = false;
        kontrol = false;
        animator.SetTrigger("oyunbitti");
        
        anaCember.GetComponent<anacember>().text1();

        
        leveltext.text = "";
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("AnaMenü");
    }
   }
