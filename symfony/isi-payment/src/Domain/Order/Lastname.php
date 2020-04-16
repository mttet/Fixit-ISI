<?php

namespace App\Domain\Order;
use Doctrine\ORM\Mapping as ORM;

/**
 * Class Lastname
 * @package App\Domain\Order
 * @ORM\Embeddable
 */
class Lastname
{
    /**
     * @var string
     * @ORM\Column(name="lastname", type="string")
     */
    private string $value;

    public function __construct(string $value)
    {
        if ($value == "") {
            throw new \InvalidArgumentException('Invalid lastname format');
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