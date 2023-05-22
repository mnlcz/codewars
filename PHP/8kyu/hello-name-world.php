<?php

function hello($name = ""): string
{
    $name = strlen($name) === 0 ? "World" : ucfirst(strtolower($name));
    return "Hello, $name!";
}