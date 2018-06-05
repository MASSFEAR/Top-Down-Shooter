using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour {

    public float Score;
    public float MoveSpeed;
    private Vector3 moveInput;
    private Vector3 PlayerVelocity;
    private Camera mainCamera;
    public PistolGunController PistolGun;
    private Rigidbody rb;
    public float cur_HP;    
    public float max_HP;    
    public float cur_Shield;    
    public float max_Shield;
    [SerializeField]
    private Image HP;
    [SerializeField]
    private Image Shield;
    public float DMG = 10;
    private GunBool gunBoolean;
    [SerializeField]
    private GameObject m_Pistole;

    void Start () {
        rb = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
        max_HP = 100;
        max_Shield = 100;
        cur_HP = max_HP;
        cur_Shield = max_Shield;
        gunBoolean = FindObjectOfType<GunBool>();
        m_Pistole.SetActive(false);
        Score = 0;
        
	}	
	void Update () {


        HP.fillAmount = cur_HP / max_HP;
        Shield.fillAmount = cur_Shield / max_Shield;
        if (Input.GetKeyDown(KeyCode.F1))
        {
            cur_HP = 1000;
            max_HP = 1000;
            cur_Shield = 1000;
            max_Shield = 1000;
        }
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        PlayerVelocity = moveInput * MoveSpeed;
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);       
        Vector3 pointToLook = Vector3.zero;
        pointToLook = cameraRay.GetPoint((100));
        Vector3 newDirection = (transform.position - pointToLook).normalized;
        newDirection.y = 0;
        transform.rotation = Quaternion.LookRotation(-newDirection, Vector3.up);

        if (Input.GetMouseButtonDown(0))
        {
            PistolGun.IsFiring = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            PistolGun.IsFiring = false;
        }
        if(cur_HP <= 0)
        {
            SceneManager.LoadScene("EndScreen_Scene");
        }
        if(cur_HP >= max_HP)
        {
            cur_HP = max_HP;
        }
        if (cur_Shield >= max_Shield)
        {
            cur_Shield = max_Shield;
        }

        if(gunBoolean.m_Pistol == true)
        {
            m_Pistole.SetActive(true);
        }




    }
    void FixedUpdate()
    {
        rb.velocity = PlayerVelocity;
    }
    void LateUpdate()
    {
        mainCamera.transform.position = new Vector3(transform.position.x, mainCamera.transform.position.y, transform.position.z - 5f);
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 60), "Score : " + Score);
    }
}
