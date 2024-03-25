public class Script : MonoBehaviour
{
    public int playerHealth;
    Rigidbody2D rb;
    Vector2 Vector; 
    float x_speed;
    float y_speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
         x_speed = 2f;
         y_speed = 3f;

        
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log("Hello, I'm here.");
        
    }

    void Awake()
    {
        playerHealth = 100;
        Debug.Log(playerHealth);
    }

    void FixedUpdate()
    {
        Debug.Log("Update time :" + Time.deltaTime);
        Vector = new Vector2(x_speed,y_speed);
        Debug.Log(Vector);
    }
}
