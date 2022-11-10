<?php

Patterns::init();

$form = [
    new Params([
        "name" => "name",
        "classInput" => "",
        "pattern" => Patterns::findRegex("chaineCaractere"),
        "title" => Patterns::findMsgErrorRegex("chaineCaractere"),
        "text" => "Entrez le nom",
        "classLabel" => "",
        "classMessage" => "",
        "classPicto" => ""
    ]),
    new Params([
        "name" => "prenom",
        "classInput" => "",
        "pattern" => Patterns::findRegex("chaineCaractere"),
        "title" =>  Patterns::findMsgErrorRegex("chaineCaractere"),
        "text" => "Entrez le prénom",
        "classLabel" => "",
        "classMessage" => "",
        "classPicto" => ""
    ]),
    new Params([
        "name" => "num",
        "classInput" => "",
        "pattern" => Patterns::findRegex("num"),
        "title" => Patterns::findMsgErrorRegex("num"),
        "text" => "Entrez le numéro de téléphone",
        "classLabel" => "",
        "classMessage" => "",
        "classPicto" => ""
    ]),
    new Params([
        "name" => "code",
        "classInput" => "",
        "pattern" => Patterns::findRegex("code"),
        "title" => Patterns::findMsgErrorRegex("code"),
        "text" => "Entrez le code postal",
        "classLabel" => "",
        "classMessage" => "",
        "classPicto" => "",
    ]),
    new Params([
        "name" => "mail",
        "classInput" => "",
        "type" => "mail",
        "pattern" => Patterns::findRegex("mail"),
        "title" => Patterns::findMsgErrorRegex("mail"),
        "text" => "Entrez l'adresse email",
        "classLabel" => "",
        "classMessage" => "",
        "classPicto" => "",
    ]),
    new Params([
        "name" => "mdp",
        "classInput" => "",
        "type" => "password",
        "pattern" => Patterns::findRegex("mdp"),
        "title" => Patterns::findMsgErrorRegex("mdp"),
        "text" => "Entrez le mot de passe",
        "classLabel" => "",
        "classMessage" => "",
        "classPicto" => "",
    ]),
];