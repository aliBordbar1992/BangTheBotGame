namespace Bang.Model
{
    public abstract class ICharacter
    {
        public abstract void Shoot();
        public abstract void Heal();
        public abstract void Die();
        public abstract void HitByBullet();
        public abstract void HitByArrow();
        public abstract void DiscardArrow();
    }
}