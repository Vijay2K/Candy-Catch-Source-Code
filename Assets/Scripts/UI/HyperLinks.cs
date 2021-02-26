using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperLinks : MonoBehaviour
{
    [SerializeField] private string faceBookLink = null;
    [SerializeField] private string twitterLink = null;
    [SerializeField] private string instagramLink = null;
    [SerializeField] private string privacyPolicy = null;
    [SerializeField] private string termsOfUse = null;

    public void FaceBook() {
        Application.OpenURL(faceBookLink);
    }

    public void Twitter() {
        Application.OpenURL(twitterLink);
    }

    public void Instagram() {
        Application.OpenURL(instagramLink);
    }

    public void PrivacyPolicy() {
        Application.OpenURL(privacyPolicy);
    }

    public void TermsOfUse() {
        Application.OpenURL(termsOfUse);
    }
}
