using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menukontrol : MonoBehaviour
{
    void start()
    {

       // PlayerPrefs.DeleteAll();

    }


   public void oyunagir()
    {
       // int kayıtlılevel = PlayerPrefs.GetInt("kayıt");
       // if (kayıtlılevel == 0)
        //{
            SceneManager.LoadScene("1");
       // }
        //else
       // {
            //SceneManager.LoadScene(kayıtlılevel);
       // }
    }



    public void oyundancık()
    {

        Application.Quit();

    }

}
