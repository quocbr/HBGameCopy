using UnityEngine;

public class PatrolState : IState
{
    private float timer;
    private float randomTime;

    public void OnEnter(Enemy enemy)
    {
        timer = 0f;
        randomTime = Random.Range(1f, 3f);
    }

    public void OnExecute(Enemy enemy)
    {
        timer += Time.deltaTime;
        if (enemy.Target != null)
        {
            //Doi huong enemy den huong player
            enemy.changeDirection(enemy.Target.transform.position.x > enemy.transform.position.x);
            if (enemy.IsTargetInRange())
            {
                enemy.ChangeState(new AttackState());
            }
            else
            {
                enemy.Moving();
            }
        }
        else
        {
            if (timer < randomTime)
            {
                enemy.Moving();
            }
            else
            {
                enemy.ChangeState(new IdleState());
            }
        }

    }

    public void OnExit(Enemy enemy)
    {

    }
}
