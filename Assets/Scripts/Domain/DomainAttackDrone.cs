public class DomainAttackDrone {
    public int amount { get; private set; }

    public int levelOfDamage { private set; get; }
    public int levelOfReloadSpeed { private set; get; }
    public int levelOfRange { private set; get; }
    public int levelOfRebuildTime { private set; get; }
    public int levelOfArmor { private set; get; }


    public DomainAttackDrone(int startAmount, int startDamage, int startReloadSpeed,
        int startRange, int startRebuildTime, int startArmor) {
        amount = startAmount;
        levelOfDamage = startDamage;
        levelOfReloadSpeed = startReloadSpeed;
        levelOfRange = startRange;
        levelOfRebuildTime = startRebuildTime;
        levelOfArmor = startArmor;
    }
    public float getDamage() {
        return DomainStats.attackDroneDamage[levelOfDamage - 1];
    }
    public float getReloadSpeed() {
        return DomainStats.attackDroneReloadSpeed[levelOfReloadSpeed - 1];
    }
    public float getRange() {
        return DomainStats.attackDroneRange[levelOfRange - 1];
    }
    public float getRebuildTime() {
        return DomainStats.attackDroneRebuild[levelOfRebuildTime - 1];
    }

    public float getArmor() {
        return DomainStats.attackDroneArmor[levelOfArmor - 1];
    }

    public void upgradeAmount() {
        amount++;
    }
    public void upgradeArmor() {
        levelOfArmor++;
    }
    public void upgradeRange() {
        levelOfRange++;
    }
    public void upgradeRebuildTime() {
        levelOfRebuildTime++;
    }

    public void upgradeReloadSpeed() {
        levelOfReloadSpeed++;
    }

    public void upgradeDamage() {
        levelOfDamage++;
    }

    public bool isArmorUpgradable() {
        return levelOfArmor <= DomainStats.attackDroneArmor.Length - 1;
    }
    public bool isRangeUpgradable() {
        return levelOfRange <= DomainStats.attackDroneRange.Length - 1;
    }
    public bool isRebuildTimeUpgradable() {
        return levelOfRebuildTime <= DomainStats.attackDroneRebuild.Length - 1;
    }
    public bool isReloadSpeedUpgradable() {
        return levelOfReloadSpeed <= DomainStats.attackDroneReloadSpeed.Length - 1;
    }
    public bool isDamageUpgradable() {
        return levelOfDamage <= DomainStats.attackDroneDamage.Length - 1;
    }
}
