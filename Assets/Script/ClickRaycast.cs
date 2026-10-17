using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script de gestion des clics souris pour détecter et détruire les ennemis
/// Utilise un raycast 2D pour détecter les colliders au point cliqué
/// </summary>
public class ClickRaycast : MonoBehaviour
{
    // Référence au gestionnaire du jeu
    private GameObject manager;
    private GameManagerScript managerScript;

    // Caméra utilisée pour convertir les positions souris
    public Camera cam;

    // Point d'impact du clic (utilisé pour les animations)
    private Vector2 hitPoint;

    /// Initialisation : trouve et récupère le script du gestionnaire de jeu
    void Start()
    {
        manager = GameObject.Find("GameManager");
        managerScript = manager.GetComponent<GameManagerScript>();
    }


    /// Détecte les clics souris et détruit les objets cliqués
    void Update()
    {
        // Vérifie si le bouton gauche de la souris est cliqué
        if (Input.GetMouseButtonDown(0))
        {
            // Convertit la position écran de la souris en position monde 3D
            Vector3 mouseWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);

            // Convertit en coordonnées 2D (supprime l'axe Z)
            Vector2 clickPos = new Vector2(mouseWorldPos.x, mouseWorldPos.y);

            // Lance un raycast 2D depuis le point cliqué vers le bas (100 unités de portée)
            RaycastHit2D hit = Physics2D.Raycast(clickPos, Vector2.down, 100f);

            // Si un collider 2D est trouvé
            if (hit.collider != null && hit.collider.gameObject.CompareTag("Ennemy"))
            {
                // Sauvegarde le point d'impact pour les animations (converti en Vector3)
                hitPoint = hit.point;

                // Affiche un message de débogage
                print("touché at: " + hitPoint);

                // Ajoute un point au score
                managerScript.ajoutPointScore();

                // Détruit l'objet cliqué
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
