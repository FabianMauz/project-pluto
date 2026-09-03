public class MainCannonShop {
    private DomainShip ship;
    private Shop shop;

    public MainCannonShop(DomainShip ship, Shop shop) {
        this.ship = ship;
        this.shop = shop;
    }

    public float getCostOfDamage() {
        return ship.mainCanon.getCostOfDamageUpgrade() * shop.multiplier;
    }
    public float getCostOfReloadSpeed() {
        return ship.mainCanon.getCostOfReloadSpeedUpgrade() * shop.multiplier;
    }

    public float getCostOfAmount() {
        return ship.mainCanon.getCostOfAmountUpgrade() * shop.multiplier;
    }

    public bool isMainCannonDamageAffordable() {
        return ship.resources >= getCostOfDamage();
    }
    public bool isMainCannonReloadSpeedAffordable() {
        return ship.resources >= getCostOfReloadSpeed();
    }
    public bool isMainCannonAmountAffordable() {
        return ship.resources >= getCostOfAmount();
    }

    public void upgradeMainCannonDamage() {
        if (ship.mainCanon.isDamageUpgradable() && isMainCannonDamageAffordable()) {
            ship.spentResources(getCostOfDamage());
            shop.increaseMultiplier();
            ship.mainCanon.upgradeDamage();
        }
    }
    public void upgradeMainCannonReloadSpeed() {
        if (ship.mainCanon.isReloadSpeedUpgradable() && isMainCannonReloadSpeedAffordable()) {
            ship.spentResources(getCostOfReloadSpeed());
            shop.increaseMultiplier();
            ship.mainCanon.upgradeReloadSpeed();
        }
    }
    public void upgradeMainCannonAmount() {
        if (ship.mainCanon.isAmountUpgradable() && isMainCannonAmountAffordable()) {
            ship.spentResources(ship.mainCanon.getCostOfAmountUpgrade());
            shop.increaseMultiplier();
            ship.mainCanon.upgradeAmount();
        }
    }
}
