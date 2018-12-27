using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Animator))]
public class Actions : MonoBehaviour {

	private Animator animator;


    //Variables para controlar el movimiento
    public float speed = 6f;

    //Variable para almacenar el movimiento que queremos aplicar al personaje
    Vector3 movement;
    Rigidbody playerRigidbody;
    float camRayLength = 100f;

    //Variable para tener en cuenta solo el suelo a la hora de girarnos
    int floorMask;




    const int countOfDamageAnimations = 3;
	int lastDamageAnimation = -1;

	void Awake () {


        // Create a layer mask for the floor layer.
        floorMask = LayerMask.GetMask("Floor");

        animator = GetComponent<Animator> ();
        playerRigidbody = GetComponent<Rigidbody>();


    }


    void FixedUpdate()
    {
        // Store the input axes.
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // Move the player around the scene.
        Move(h, v);

        // Turn the player to face the mouse cursor.
        Turning();

        // Animate the player.
        Animating(h, v);
    }

    void Move(float h, float v)
    {
        //Fija el movimiento en funcion de los valores horizontal y vertical del input
        movement.Set(h, 0f, v);

        //Normalizar el vector de movimiento para que la velocidad diagonal no sea superior.
        movement = movement.normalized * speed * Time.deltaTime;

        //Movemos el personaje a su posición más el movimiento que hemos aplicado
        playerRigidbody.MovePosition(transform.position + movement);
    }


    void Turning()
    {
        //Rayo de la camara a la posición del raton
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        //Variable para almacenar informacion sobre lo que fue golpeado por el rayo
        RaycastHit floorHit;

        //Lanza y rallo y si ha golpeado algo etiquetado como suelo
        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            //Vector que va del jugador al punto donde golpeo el rayo al cursor
            Vector3 playerToMouse = floorHit.point - transform.position;

            //El vector debe tener altura 0
            playerToMouse.y = 0f;

            //Quaternio con la rotación a la que mirara el personaje
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);


            //Mira hacia esa posición.
            playerRigidbody.MoveRotation(newRotation);
        }
    }


    void Animating(float h, float v)
    {
        // Create a boolean that is true if either of the input axes is non-zero.
        bool walking = h != 0f || v != 0f;

        if (walking)
            Walk();
        else
            Stay();

        /*
        if (Input.GetMouseButtonDown(0))
            //Attack();
        */
    }

    public void Stay () {
		animator.SetBool("Aiming", false);
		animator.SetFloat ("Speed", 0f);
		}

	public void Walk () {
		animator.SetBool("Aiming", false);
		animator.SetFloat ("Speed", 0.5f);
	}

	public void Run () {
		animator.SetBool("Aiming", false);
		animator.SetFloat ("Speed", 1f);
	}

	public void Attack () {
		Aiming ();
		animator.SetTrigger ("Attack");
	}

	public void Death () {
		if (animator.GetCurrentAnimatorStateInfo (0).IsName ("Death"))
			animator.Play("Idle", 0);
		else
			animator.SetTrigger ("Death");
	}

	public void Damage () {
		if (animator.GetCurrentAnimatorStateInfo (0).IsName ("Death")) return;
		int id = Random.Range(0, countOfDamageAnimations);
		if (countOfDamageAnimations > 1)
			while (id == lastDamageAnimation)
				id = Random.Range(0, countOfDamageAnimations);
		lastDamageAnimation = id;
		animator.SetInteger ("DamageID", id);
		animator.SetTrigger ("Damage");
	}

	public void Jump () {
		animator.SetBool ("Squat", false);
		animator.SetFloat ("Speed", 0f);
		animator.SetBool("Aiming", false);
		animator.SetTrigger ("Jump");
	}

	public void Aiming () {
		animator.SetBool ("Squat", false);
		animator.SetFloat ("Speed", 0f);
		animator.SetBool("Aiming", true);
	}

	public void Sitting () {
		animator.SetBool ("Squat", !animator.GetBool("Squat"));
		animator.SetBool("Aiming", false);
	}
}
