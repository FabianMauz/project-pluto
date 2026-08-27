public class DomainDrive {

    public int levelOfSpeed { private set; get; }
    public int levelOfEvade { private set; get; }
    public float getEvadeChance() {
        return (levelOfEvade - 1) * 0.05f;
    }

    public DomainDrive(int startSpeed, int startEvade) {
        levelOfEvade = startEvade;
        levelOfSpeed = startSpeed;

    }

    public float getSpeed() {
        return 3 + .25f * levelOfSpeed;
    }

    public void upgradeSpeed() {
        levelOfSpeed++;
    }

    public void upgradeEvade() {
        levelOfEvade++;
    }

    public bool isEvadeUpgradable() {
        return levelOfEvade <= 5;
    }
    public bool isSpeedUpgradable() {
        return levelOfSpeed <= 5;
    }


}
