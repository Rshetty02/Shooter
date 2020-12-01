using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Objective), typeof(Collider))]
public class ObjectiveReachPoint : MonoBehaviour
{
    [Tooltip("Visible transform that will be destroyed once the objective is completed")]
    public Transform destroyRoot;

    public int score;

    UnityAds iad = new UnityAds();

    Objective m_Objective;

    void Awake()
    {
        m_Objective = GetComponent<Objective>();
        DebugUtility.HandleErrorIfNullGetComponent<Objective, ObjectiveReachPoint>(m_Objective, this, gameObject);

        if (destroyRoot == null)
            destroyRoot = transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if (m_Objective.isCompleted)
            return;

        var player = other.GetComponent<PlayerCharacterController>();
        // test if the other collider contains a PlayerCharacterController, then complete
        if (player != null)
        {
            m_Objective.CompleteObjective(string.Empty, string.Empty, "Objective complete : " + m_Objective.title);
            
            score = GolabalScore.scoreValue + PlayerPrefs.GetInt("HighScore");
            PlayerPrefs.SetInt("HighScore",score);
            iad.DisplayInterstitialAD();
            // destroy the transform, will remove the compass marker if it has one
            Destroy(destroyRoot.gameObject); 
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
