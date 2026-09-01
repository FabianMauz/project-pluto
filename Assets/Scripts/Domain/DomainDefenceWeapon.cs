public class DomainDefenceWeapon {
    public int amount { get; private set; }
    public int levelOfDamage { get; private set; }
    public int levelOfRange { get; private set; }
    public int levelOfReloadSpeed { get; private set; }


    public DomainDefenceWeapon(int startAmount, int startDamage, int startRange, int startReloadSpeed) {
        amount = startAmount;
        levelOfDamage = startDamage;
        levelOfRange = startRange;
        levelOfReloadSpeed = startReloadSpeed;
    }
    public void upgradeDamage() {
        levelOfDamage++;
    }

    public bool isDamageUpgradable() {
        return levelOfDamage <= DomainStats.defenceCannonDamage.Length - 1;
    }

    public float getDamage() {
        return DomainStats.defenceCannonDamage[levelOfDamage - 1];
    }
    public void upgradeRange() {
        levelOfRange++;
    }

    public bool isRangeUpgradable() {
        return levelOfRange <= DomainStats.defenceCannonRange.Length - 1;
    }

    public float getRange() {
        return DomainStats.defenceCannonRange[levelOfRange - 1];
    }
    public void upgradeReloadSpeed() {
        levelOfReloadSpeed++;
    }

    public bool isReloadSpeedUpgradable() {
        return levelOfReloadSpeed <= DomainStats.defenceCannonReloadSpeed.Length - 1;
    }

    public float getReloadSpeed() {
        return DomainStats.defenceCannonReloadSpeed[levelOfReloadSpeed - 1];
    }
    public void upgradeAmount() {
        amount++;
    }

    public bool isAmountUpgradable() {
        return amount < 2;
    }
}
