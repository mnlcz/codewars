<?php

function dutyFree(int $n, int $d, int $h): int
{
    return $h / (($n * $d) / 100);
}