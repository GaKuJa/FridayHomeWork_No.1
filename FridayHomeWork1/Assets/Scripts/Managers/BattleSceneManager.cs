using System.Timers;
using UnityEngine;

public class BattleSceneManager : MonoBehaviour
{
    public  static BattleSceneManager Instance { get => _instance; }
    private static BattleSceneManager _instance;

    [SerializeField]
    private int trunChangeNum = 0;
    
    private int battleTrunNum;

    private static Timer battleTimer;
    
    [SerializeField]
    private PlayerManager playerManager = null;
    
    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        battleTimer         =  new Timer(trunChangeNum * 1000);
        battleTimer.Elapsed += new ElapsedEventHandler(TrunPluse);
        
        battleTimer.Start();
    }

    public void TrunPluse(object sender, ElapsedEventArgs e)
    {
        battleTrunNum++;
        
        playerManager.DoPlayerAction(battleTrunNum);
    }

    private void OnDestroy()
    {
        battleTimer.Stop();
    }
}
