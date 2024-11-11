using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public void to3DMask()
    {
        SceneManager.LoadScene("3DmaskScene");
    }

    public void to3DTex()
    {
        SceneManager.LoadScene("TEXMaskScene");
    }

    public void toVidTex()
    {
        SceneManager.LoadScene("TEXVideoScene");
    }
}
