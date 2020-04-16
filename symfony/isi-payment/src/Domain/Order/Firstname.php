<?php

namespace App\Domain\Order;
use Doctrine\ORM\Mapping as ORM;

/**
 * Class Firstname
 * @package App\Domain\Order
 * @ORM\Embeddable
 */
class Firstname
{
    /**
     * @var string
     * @ORM\Column(name="firstname", type="string")
     */
    private string $value;

    public function __construct(string $value)
    {
        if ($value == "") {
            throw new \InvalidArgumentException('Invalid firstname format');
        }

        $this->value = $value;
    }

    public function __toString(): string
    {
        return $this->value;
    }

    public function isEqual(self $name): bool
    {
        return $this->value === $name->value;
    }
}