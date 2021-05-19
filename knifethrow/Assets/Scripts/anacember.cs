using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class anacember : MonoBehaviour
{
    // bool kont = true;
    public GameObject textgecis;
    public Animator animator;
    public GameObject OyunYönetim;
    public GameObject dön;
    public GameObject atıs;
    public GameObject kucukcember;
    public Text bıcaktext;
    public int sayi;
    public int a=1;

    void Start()
    {
        OyunYönetim = GameObject.FindGameObjectWithTag("oyunyonetımıtag");
        dön = GameObject.FindGameObjectWithTag("donencembertag");
        atıs = GameObject.FindGameObjectWithTag("anakılıctag");
        
        a = a + 1;
        
    }

    public void text1()
    {

        bıcaktext.text = "";

    }



   
    
      void Update()
    {
        bıcaktext.text = "Knife:" + " " + sayi;

        if (Input.GetButtonDown("Fire1"))
        {
            
         kucukcemberolustur();
            
        }
        SahneGiris();

    }
    void kucukcemberolustur()
    {
        Instantiate(kucukcember, transform.position, transform.rotation);

        sayi = sayi - 1;

    }
    public void SahneGiris()
    {
        
        StartCoroutine(sahnegiris());
    }

   IEnumerator sahnegiris()
    {
      
        if (sayi == 0)
        {
            

            dön.GetComponent<Dondurme>().enabled = false;
            atıs.GetComponent<anacember>().enabled = false;
            OyunYönetim.GetComponent<oyunyonetim>().text2();
            //kont = OyunYönetim.GetComponent<oyunyonetim>().kontrol;
            bıcaktext.text = "Knife:0";
            yield return new WaitForSeconds(0.5f);
            
            if (OyunYönetim.GetComponent<oyunyonetim>().kontrol)
            {
                bıcaktext.text = "";
                if (int.Parse(SceneManager.GetActiveScene().name) == 1) {animator.SetTrigger("levelup"); }
                if (int.Parse(SceneManager.GetActiveScene().name) == 2) { animator.SetTrigger("levelup2"); }

                yield return new WaitForSeconds(1.5f);
                SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
            }

        }
    }




}
