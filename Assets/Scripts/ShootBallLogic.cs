using UnityEngine;

public class ShootBallLogic : MonoBehaviour
{
    [SerializeField] private Camera arCamera; 
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float ballForwardForce = 800f; // Ανέβασα λίγο τη δύναμη
    [SerializeField] private AudioClip spawnSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null) audioSource = gameObject.AddComponent<AudioSource>();

        UIButtonHandler.OnUIShootButtonClicked += ShootBallOnButton;
        Debug.Log("✅ Το Script ξεκίνησε και περιμένει το πάτημα...");
    }

    private void ShootBallOnButton()
    {
        Debug.Log("🔘 Πατήθηκε το κουμπί SHOOT!");

        if (arCamera == null)
        {
            Debug.LogError("❌ ΛΕΙΠΕΙ Η ΚΑΜΕΡΑ (Ar Camera)!");
            return;
        }
        if (ballPrefab == null)
        {
            Debug.LogError("❌ ΛΕΙΠΕΙ Η ΜΠΑΛΑ (Ball Prefab)!");
            return;
        }

        Vector3 spawnPosition = arCamera.transform.position + arCamera.transform.forward * 0.2f;
        Quaternion spawnRotation = arCamera.transform.rotation;

        GameObject spawnBall = Instantiate(ballPrefab, spawnPosition, spawnRotation);
        Debug.Log("⚽ Η μπάλα γεννήθηκε!");

        if (audioSource != null && spawnSound != null)
        {
            audioSource.PlayOneShot(spawnSound);
        }
        
        Rigidbody rb = spawnBall.GetComponent<Rigidbody>();

        if(rb != null)
        {
            rb.AddForce(arCamera.transform.forward * ballForwardForce);
            Debug.Log("🚀 Εφαρμόστηκε δύναμη: " + ballForwardForce);
        }
        else
        {
            Debug.LogError("❌ Η ΜΠΑΛΑ ΔΕΝ ΕΧΕΙ RIGIDBODY! Δεν μπορεί να κουνηθεί.");
        }

        Destroy(spawnBall, 5f);
    }
    
    private void OnDestroy()
    {
        UIButtonHandler.OnUIShootButtonClicked -= ShootBallOnButton;
    }
}