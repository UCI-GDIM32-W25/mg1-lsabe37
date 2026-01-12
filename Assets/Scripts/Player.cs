using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private GameObject _plantPrefab;
    public int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;
    [SerializeField] private Animator anim;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
    }

    private void Update()
    {
        // horizontal movement
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 horMovement = Vector2.right * horizontalInput * _speed * Time.deltaTime;
        transform.Translate(horMovement);

        // vertical movement
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 verMovement = Vector2.up * verticalInput * _speed * Time.deltaTime;
        transform.Translate(verMovement);

        //plant seed
        if (Input.GetKeyDown(KeyCode.Space) && _numSeedsLeft > 0)
        {
            PlantSeed();
        }

        // animations
        if(horizontalInput == 0 && verticalInput == 0)
        {
            anim.SetBool("walkRight", false);
            anim.SetBool("walkLeft", false);
            anim.SetBool("walkUp", false);
            anim.SetBool("walkDown", false);
        }

        if (horizontalInput > 0)
        {
            anim.SetBool("walkRight", true);
            anim.SetBool("walkLeft", false);
            anim.SetBool("walkUp", false);
            anim.SetBool("walkDown", false);
        }
        else if (horizontalInput < 0)
        {
            anim.SetBool("walkLeft", true);
            anim.SetBool("walkRight", false);
            anim.SetBool("walkUp", false);
            anim.SetBool("walkDown", false);
        }

        if (horizontalInput == 0 && verticalInput > 0)
        {
            anim.SetBool("walkUp", true);
            anim.SetBool("walkDown", false);
            anim.SetBool("walkRight", false);
            anim.SetBool("walkLeft", false);
        }
        else if (horizontalInput == 0 && verticalInput < 0)
        {
            anim.SetBool("walkDown", true);
            anim.SetBool("walkUp", false);
            anim.SetBool("walkRight", false);
            anim.SetBool("walkLeft", false);
        }

    }

    public void PlantSeed()
    {
        Instantiate(_plantPrefab, transform.position, Quaternion.identity);

        _numSeedsLeft -= 1;
        _numSeedsPlanted += 1;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
