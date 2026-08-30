public abstract class DomainStats {
    //Missile
    public static float[] missileDamage = new float[] { 20, 35, 50, 65, 80 };
    public static float[] missileRange = new float[] { 5, 5.5f, 6, 6.5f, 7 };
    public static float[] missileReloadSpeed = new float[] { 5, 4.5f, 4, 3.5f, 3 };
    public static float[] missileArmor = new float[] { 1, 2, 3, 4, 5 };
    public static int MAX_MISSILE_AMOUNT = 3;
    //Shield
    public static float[] shieldValue = new float[] { 10, 25, 40, 55, 70 };
    public static float[] shieldRechargeDelay = new float[] { 6, 5, 4, 3, 2 };
    public static float[] shieldRechargePerSecond = new float[] { 1, 2, 3, 4, 5 };
    //Drive
    public static float[] driveEvadeChance = new float[] { 0, .05f, .1f, .15f, .2f };
    public static float[] driveSpeed = new float[] { 3, 3.25f, 3.5f, 3.75f, 4 };
    //Armor
    public static float[] armorValue = new float[] { 50, 60, 70, 80, 90 };
    public static float[] armorReducution = new float[] { 0, 1, 2, 3, 4 };

    //Main Cannon
    public static float[] mainCannonDamage = new float[] { 10, 20, 30, 40, 50 };
    public static float[] mainCannonReloadSpeed = new float[] { 1, .9f, .8f, .7f, .6f };
    //Defence Cannon
    public static float[] defenceCannonDamage = new float[] { 5, 10, 15, 20, 25 };
    public static float[] defenceCannonRange = new float[] { 1, 1.5f, 2, 2.5f, 3 };
    public static float[] defenceCannonReloadSpeed = new float[] { 2, 1.8f, 1.6f, 1.4f, 1.2f };
    //Attack Drone
    public static float[] attackDroneDamage = new float[] { 5, 10, 15, 20, 25 };
    public static float[] attackDroneReloadSpeed = new float[] { 2, 1.8f, 1.6f, 1.4f, 1.2f };
    public static float[] attackDroneRange = new float[] { .5f, .75f, 1, 1.25f, 1.5f };
    public static float[] attackDroneRebuild = new float[] { 40, 35, 30, 25, 20f };
    public static float[] attackDroneArmor = new float[] { 5, 10, 15, 20, 25 };
}
