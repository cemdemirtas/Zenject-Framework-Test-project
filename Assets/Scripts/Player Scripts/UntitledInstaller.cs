using UnityEngine;
using Zenject;

public class UntitledInstaller : MonoInstaller
{
    PlayerController playerController;


    public Transform PlayerSpawnPoint;
    public GameObject PlayerPrefab; //reach from enemy script
    public PlayerHealth PlayerHealth; //direct script
    //public Transform[] SpawnPositions;

    public override void InstallBindings()
    {
        //init by prefabs
        playerController = Container.InstantiatePrefabForComponent<PlayerController>(PlayerPrefab, PlayerSpawnPoint.position, Quaternion.identity, null);
        Container.Bind<PlayerController>().FromInstance(playerController).AsSingle();
        //direct script
        Container.Bind<PlayerHealth>().FromInstance(PlayerHealth).AsSingle();
    }
    private void BindPlayer() //from Enemycontroller
    {
    }

}