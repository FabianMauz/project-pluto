public class DomainDrive {
    public int levelOfSpeed { private set; get; }
    public int levelOfEvade { private set; get; }
    public DomainDrive(int startSpeed, int startEvade) {
        levelOfEvade = startEvade;
        levelOfSpeed = startSpeed;
    }
    public float getEvadeChance() {
        return DomainStats.driveEvadeChance[levelOfEvade - 1];
    }

    public float getSpeed() {
        return DomainStats.driveSpeed[levelOfSpeed - 1];
    }

    public void upgradeSpeed() {
        levelOfSpeed++;
    }

    public void upgradeEvade() {
        levelOfEvade++;
    }

    public bool isEvadeUpgradable() {
        return levelOfEvade <= DomainStats.driveEvadeChance.Length - 1;
    }
    public bool isSpeedUpgradable() {
        return levelOfSpeed <= DomainStats.driveSpeed.Length - 1;
    }
}
