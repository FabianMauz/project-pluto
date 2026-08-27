public class DomainArmor {
    public int levelOfArmorValue { private set; get; }
    public int levelOfArmorReduction { private set; get; }

    public float getArmorValue() {
        return 50 + (levelOfArmorValue - 1) * 10;
    }
    public float getArmorReduction() {
        return levelOfArmorReduction - 1;
    }

    public void upgradeValue() {
        levelOfArmorValue++;
    }

    public void upgadeReduction() {
        levelOfArmorReduction++;
    }

    public bool isValueUpgradable() {
        return levelOfArmorValue <= 4;
    }
    public bool isReductionUpgradable() {
        return levelOfArmorReduction <= 4;
    }
}
