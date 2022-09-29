using UnityEngine;
using UnityEngine.UI;

namespace Player
{


    public class PlayerScript : MonoBehaviour
    {
        [SerializeField] private Text currentState;
        public StateMachine sm;

        public Rigidbody2D rb;


        // Add your variables holding the different player states here
        public StandingState standingState;
        public JumpingState jumpingState;
        public MovingState movingState;

        public float xv, yv;

        // Start is called before the first frame update
        void Start()
        {
            sm = gameObject.AddComponent<StateMachine>();

            // set up the variables for your new states here
            standingState = new StandingState(this, sm);
            jumpingState = new JumpingState(this, sm);
            movingState = new MovingState(this, sm);

            rb = gameObject.GetComponent<Rigidbody2D>();
            
            // initialise the statemachine with the default state
            sm.Init(standingState);
        }

        // Update is called once per frame
        public void Update()
        {
            currentState.text = sm.CurrentState.ToString();
            sm.CurrentState.HandleInput();
            sm.CurrentState.LogicUpdate();

            
        }

        void FixedUpdate()
        {
            sm.CurrentState.PhysicsUpdate();

            rb.velocity = new Vector2(xv, yv);
        }

        public void CheckForJump()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                sm.ChangeState(jumpingState);
            }

        }

        public void CheckForStand()
        {
            if (Input.GetKey(KeyCode.A)==false && Input.GetKey(KeyCode.D)==false)
            {
                sm.ChangeState(standingState);
            }

        }
    }

}