using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public float minX;
    public float maxX;
    public float waitingTime = 2f;

    private GameObject _target;
    private Animator _animator;
    private Weapon _weapon;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _weapon = GetComponentInChildren<Weapon>();
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateTarget();
        StartCoroutine("PatrolToTarget");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void UpdateTarget()
    {
        // if first time, create target in the left
        if (_target == null)
        {
            _target = new GameObject("Target");
            _target.transform.position = new Vector2(minX, transform.position.y);
            transform.localScale = new Vector3(-1, 1, 1);
            return;
        }

        // if we are in the left, change target to the right
        if (_target.transform.position.x == minX) {
            _target.transform.position = new Vector2(maxX, transform.position.y);
            transform.localScale = new Vector3(1, 1, 1);
        }

        // if we are in the right, change target to the left
        else if (_target.transform.position.x == maxX) {
            _target.transform.position = new Vector2(minX, transform.position.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }

    private IEnumerator PatrolToTarget()
    {

        // Coroutine to move the enemy
        while (Vector2.Distance(transform.position, _target.transform.position) > 0.05f) {

            // Update animator 
            _animator.SetBool("Idle", false);

            // let's move to the target
            Vector2 direction = _target.transform.position - transform.position;
            float xDirection = direction.x;

            transform.Translate(direction.normalized * speed * Time.deltaTime);

            // IMPORTANT
            yield return null;
        }

        //at this point, i've reached the target, let's set our position to the target's one
        Debug.Log("Target reached");
        transform.position = new Vector2(_target.transform.position.x, transform.position.y);
        UpdateTarget();

        // Update animator 
        _animator.SetBool("Idle", true);

        // Shoot
        _animator.SetTrigger("Shoot");

        // And let's wait for a moment
        Debug.Log("Waiting for " + waitingTime + " seconds");
        yield return new WaitForSeconds(waitingTime); // IMPORTANT

        // onde waited, let's restore the patrol behavior
        Debug.Log("Waited enough, let's update the target and move again");
        StartCoroutine("PatrolToTarget");
    }

    void CanShoot()
    {
        if (_weapon != null) {
            _weapon.Shoot();
        }
    }
}
