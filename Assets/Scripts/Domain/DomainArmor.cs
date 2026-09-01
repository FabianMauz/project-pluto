public class DomainArmor {
    public int levelOfArmorValue { private set; get; }
    public int levelOfArmorReduction { private set; get; }


    public DomainArmor(int startValue, int startReduction) {
        levelOfArmorReduction = startReduction;
        levelOfArmorValue = startValue;
    }
    public float getArmorValue() {
        return DomainStats.armorValue[levelOfArmorValue - 1];
    }
    public float getArmorReduction() {
        return DomainStats.armorReducution[levelOfArmorReduction - 1];
    }

    public void upgradeValue() {
        levelOfArmorValue++;
    }

    public void upgadeReduction() {
        levelOfArmorReduction++;
    }

    public bool isValueUpgradable() {
        return levelOfArmorValue <= DomainStats.armorValue.Length - 1;
    }
    public bool isReductionUpgradable() {
        return levelOfArmorReduction <= DomainStats.armorReducution.Length - 1;
    }
}
