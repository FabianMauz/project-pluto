public class DomainMiningDrone {
    public int levelOfCapacity { private set; get; }
    public int levelOfMoveSpeed { private set; get; }
    public int levelOfMiningSpeed { private set; get; }

    public DomainMiningDrone(int starCapacity, int startMoveSpeed, int startMineSpeed) {
        levelOfCapacity = starCapacity;
        levelOfMiningSpeed = startMineSpeed;
        levelOfMoveSpeed = startMoveSpeed;
    }

    public float getCapacity() {
        return DomainStats.mineDroneCapacity[levelOfCapacity - 1];
    }
    public float getMoveSpeed() {
        return DomainStats.mineDroneMoveSpeed[levelOfMoveSpeed - 1];
    }
    public float getMineSpeed() {
        return DomainStats.mineDroneMineSpeed[levelOfMiningSpeed - 1];
    }
    public void upgradeMoveSpeed() {
        levelOfMoveSpeed++;
    }
    public void upgradeMineSpeed() {
        levelOfMiningSpeed++;
    }
    public void upgradeCapacity() {
        levelOfCapacity++;
    }
    public bool isMoveSpeedUpgradable() {
        return levelOfMoveSpeed <= DomainStats.mineDroneMoveSpeed.Length - 1;
    }
    public bool isMineSpeedUpgradable() {
        return levelOfMiningSpeed <= DomainStats.mineDroneMineSpeed.Length - 1;
    }
    public bool isCapacityUpgradable() {
        return levelOfCapacity <= DomainStats.mineDroneCapacity.Length - 1;
    }

}
