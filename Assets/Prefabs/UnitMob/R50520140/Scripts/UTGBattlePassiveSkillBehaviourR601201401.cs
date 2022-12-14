using UnityEngine;
using System.Collections;

public class UTGBattlePassiveSkillBehaviourR601201401 : NTGBattlePassiveSkillBehaviour
{
    public NTGBattlePassiveSkillBehaviour pBehaviour;

    public float pDuration;

    public override void Respawn()
    {
        base.Respawn();

        pDuration = duration;

        FXEA();
        FXEB();

        StartCoroutine(doBoost());
    }

    public override void Notify(NTGBattlePassive.Event e, object param)
    {
        if (e == NTGBattlePassive.Event.PassiveAdd)
        {
            var p = (NTGBattlePassiveSkillBehaviour) param;
            shooter = p.shooter;
            pDuration = p.duration;
        }
        else if (e == NTGBattlePassive.Event.Hit)
        {
            var p = (NTGBattlePassive.EventHitParam) param;
            if (p.shooter == owner && p.behaviour.type == NTGBattleSkillType.Attack)
            {
                p.target.AddPassive(pBehaviour.passiveName, owner);
            }
        }
        else if (e == NTGBattlePassive.Event.Death)
        {
            var p = (NTGBattlePassive.EventDeathParam) param;

            if (p.killer is NTGBattlePlayerController)
                p.killer.AddPassive(passiveName, owner);

            Release();
        }
        else if (e == NTGBattlePassive.Event.PassiveRemove)
        {
            Release();
        }
    }

    private IEnumerator doBoost()
    {
        while (pDuration > 0)
        {
            yield return new WaitForSeconds(0.1f);
            pDuration -= 0.1f;
        }

        Release();
    }
}