using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ArtifactManager : MonoBehaviour
{
    GameObject[] artifacts;
    GameObject artifact;
    public SpawnManager arifactsManger;
    string artifactName;
    string artifactOrigin;
    string artifactSummary;
    Image artifactImage;

    public TextMeshProUGUI artName;
    public TextMeshProUGUI origin;
    public TextMeshProUGUI summary;
    public Image image;
    Sprite imageSprite;
    // Start is called before the first frame update
    void Start()
    {
        artifact = null;
        artifacts = arifactsManger.artifacts;
    }

    // Update is called once per frame
    void Update()
    {
        if (artifact != null)
        {
            artName.SetText(artifactName);
            origin.SetText("Origin: " + artifactOrigin);
            summary.SetText("Origin: " + artifactSummary);
            image.sprite = imageSprite;
        }
    }
    public void SaveArtifact(ArtifactTrigger aritfactTrigger)
    {
        artifact = aritfactTrigger.artifactObj;
        artifactName = artifact.GetComponent<ArtifactObject>().aritfactName;
        artifactOrigin = artifact.GetComponent<ArtifactObject>().artifactOrigin;
        artifactSummary = artifact.GetComponent<ArtifactObject>().summary;
        imageSprite = artifact.GetComponent<ArtifactObject>().artifactImage;



        for (int i = 0; i < artifacts.Length; i++)
        {
            if (artifacts[i] == artifact)
            {
                //Add to inventory
            }
        }
    }
}
