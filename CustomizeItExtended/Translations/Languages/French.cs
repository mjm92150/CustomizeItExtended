using System.Collections.Generic;

namespace CustomizeItExtended.Translations.Languages
{
    public class French : BaseLanguage
    {
        public French()
        {
            FieldTranslations = new Dictionary<string, string>
            {
                {"Construction Cost", "Coût de construction"},
                {"Maintenance Cost", "Coût de maintenance"},
                {"Electricity Consumption", "Consommation d'électricité"},
                {"Water Consumption", "Consommation d'eau"},
                {"Sewage Accumulation", "Accumulation d'eaux usées"},
                {"Garbage Accumulation", "Accumulation d'ordures"},
                {"Fire Hazard", "Risque d'incendie"},
                {"Fire Tolerance", "Tolérance au feu"},
                {"Low Wealth Tourists", "Touristes à faible richesse"},
                {"Medium Wealth Tourists", "Touristes de richesse moyenne"},
                {"High Wealth Tourists", "Touristes riches"},
                {"Entertainment Accumulation", "Accumulation de divertissement"},
                {"Entertainment Radius", "Rayon de divertissement"},
                {"Uneducated Workers", "Travailleurs sans instruction"},
                {"Educated Workers", "Employé(e)s"},
                {"Well Educated Workers", "Agent de maîtrise"},
                {"Highly Educated Workers", "Cadres & Cadres supérieurs"},
                {"Noise Accumulation", "Accumulation de bruit"},
                {"Noise Radius", "Rayon de bruit"},
                {"Cargo Transport Accumulation", "Accumulation de transport de marchandises"},
                {"Cargo Transport Radius", "Rayon de transport de marchandises"},
                {"Hearse Count", "Nombre de corbillards"},
                {"Corpse Capacity", "Capacité de cadavres"},
                {"Burial Rate", "Taux d'inhumation"},
                {"Grave Count", "Nombre de tombes"},
                {"Deathcare Accumulation", "Accumulation des décès"},
                {"Deathcare Radius", "Rayon des crématoires/cimetières"},
                {"Helicopter Count", "Nombre d'hélicoptères"},
                {"Vehicle Count", "Nombre de véhicules"},
                {"Detection Range", "Portée de détection"},
                {"Fire Department Accumulation", "Accumulation des Sapeurs-Pompiers"},
                {"Fire Department Radius", "Rayon des Sapeurs-Pompiers"},
                {"Fire Truck Count", "Nombre de camions des Sapeurs-Pompiers"},
                {"Firewatch Radius", "Rayon de l'incendie"},
                {"Education Accumulation", "Accumulation d'études"},
                {"Education Radius", "Rayon de l'éducation"},
                {"Student Count", "Nombre d'élèves"},
                {"Resource Capacity", "Capacité en ressources"},
                {"Resource Consumption", "La consommation de ressources"},
                {"Heating Production", "Production de chauffage"},
                {"Pollution Accumulation", "Accumulation de pollution"},
                {"Pollution Radius", "Rayon de pollution"},
                {"Ambulance Count", "Nombre d'ambulances"},
                {"Patient Capacity", "Capacité de malade"},
                {"Curing Rate", "Taux de guérison"},
                {"Healthcare Accumulation", "Accumulation de soins de santé"},
                {"Healthcare Radius", "Rayon des soins de santé"},
                {"Animal Count", "Nombre d'animaux"},
                {"Garbage Collection Radius", "Rayon de collecte des ordures"},
                {"Electricity Production", "Production d'électricité"},
                {"Garbage Capacity", "Capacité de déchets"},
                {"Garbage Consumption", "Consommation de déchets"},
                {"Garbage Truck Count", "Nombre de camions à ordures"},
                {"Material Production", "Production de matériel"},
                {"Maintenance Radius", "Rayon de maintenance"},
                {"Maintenance Truck Count", "Nombre de camions de maintenance"},
                {"Monument Level", "Niveau du monument"},
                {"Attractiveness Accumulation", "Accumulation d'attractivité"},
                {"Land Value Accumulation", "Accumulation de la valeur des terres"},
                {"Jail Capacity", "Capacité de la prison"},
                {"Police Car Count", "Nombre de voitures de police"},
                {"Police Department Radius", "Rayon du département de police"},
                {"Police Department Accumulation", "Accumulation dans les services de police"},
                {"Sentence Weeks", "Peines hebdomadaire"},
                {"Battery Factor", "Facteur de batterie"},
                {"Transmitter Power", "Puissance de l'émetteur"},
                {"Capacity", "Capacité"},
                {"Disaster Coverage Accumulation", "Accumulation de couverture en cas de catastrophe"},
                {"Electricity Stockpile Size", "Taille des stocks d'électricité"},
                {"Electricty Stockpile Rate", "Taux de stockage d'électricité"},
                {"Water Stockpile Size", "Taille de la réserve d'eau"},
                {"Water Stockpile Rate", "Taux de stockage de l'eau"},
                {"Goods Stockpile Size", "Taille du stock de marchandises"},
                {"Goods Stockpile Rate", "Taux de stockage des marchandises"},
                {"Snow Capacity", "Capacité de neige"},
                {"Snow Consumption", "Consommation de neige"},
                {"Snowplow Count", "Compte de chasse-neige"},
                {"Public Transport Accumulation", "Accumulation des transports public"},
                {"Public Transport Radius", "Rayon des transports publics"},
                {"Resident Capacity", "Capacité résidentielle"},
                {"Tourist Factor 1", "Facteur touristique 1"},
                {"Tourist Factor 2", "Facteur touristique 2"},
                {"Tourist Factor 3", "Facteur touristique 3"},
                {"Max Vehicle Count", "Nombre maximal de véhicules"},
                {"Max Vehicle Count 2", "Nombre maximum de véhicules 2"},
                {"Cleaning Rate", "Taux de nettoyage"},
                {"Max Water Distance", "Distance maximale de l'eau"},
                {"Outlet Pollution", "Véhicules de pompage"},
                {"Pumping Vehicles", "Pumpfahrzeuge"},
                {"Sewage Outlet", "Stockage des eaux usées"},
                {"Sewage Storage", "Abwasserspeicher"},
                {"Use Ground Water", "Utiliser l'eau souterraine"},
                {"Vehicle Radius", "Rayon du véhicule"},
                {"Water Intake", "Prise d'eau"},
                {"Water Outlet", "Sortie d'eau"},
                {"Water Storage", "Réserve d'eau"},
                {"Service Radius", "Rayon de service"},
                {"Service Accumulation", "Accumulation de services"},
                {"Sorting Rate", "Taux de tri"},
                {"Mail Capacity", "Capacité de courrier"},
                {"Post Truck Count", "Nombre de Camions Postal"},
                {"Post Van Count", "Nombre de fourgonnettes Postal"},
                {"Input Rate 1", "Taux d'entrée 1"},
                {"Input Rate 2", "Taux d'entrée 2"},
                {"Input Rate 3", "Taux d'entrée 3"},
                {"Input Rate 4", "Taux d'entrée 4"},
                {"Output Rate", "Taux de sortie"},
                {"Output Vehicle Count", "Nombre de véhicules en sortie"},
                {"Extract Radius", "Rayon d'extraction"},
                {"Extract Rate", "Taux d'extraction"},
                {"Storage Capacity", "Capacité de stockage"},
                {"Truck Count", "Nombre de camions"},
                {"Bonus Effect Radius", "Rayon d'effet bonus"},
                {"Land Value Bonus", "Bonus de valeur foncières"},
                {"Health Bonus", "Bonus de santé"},
                {"Academic Boost Bonus", "Bonus de boost académique"},
                {"Tourism Bonus", "Bonus Tourisme"},
                {"Faculty Bonus Factor", "Facteur bonus de la faculté"},
                {"Campus Attractiveness", "Attractivité du campus"}
            };

            InformationTranslations = new Dictionary<string, string>
            {
                {
                    " A Customization and Information Viewer for Buildings, Vehicles and Citizens",
                    " Un visualiseur de personnalisation et d'informations pour les bâtiments, les véhicules et les citoyens"
                },
                {"Save Per City", "Enregistrer par ville"},
                {"This option is only available in the main menu.", "Cette option n'est disponible que dans le menu principal."},
                {"Override Rebalanced Industries", "Remplacer les industries rééquilibrées"},
                {
                    "EXPERIMENTAL - This will cause your Industry buildings to revert back to Vanilla",
                    "EXPÉRIMENTAL - Cela fera revenir vos bâtiments de l'industrie à la vanille"
                },
                {"Reset ALL Buildings", "Réinitialiser TOUS les bâtiments"},
                {"The option is only available in game.", "L'option n'est disponible qu'en jeu."},
                {"Import Old Settings", "Importer les anciens paramètres"},
                {
                    "Note: This will import your old Customize It settings into Customize It Extended.",
                    "Remarque: Cela importera vos anciens paramètres de personnalisation de Customize It Extended."
                },
                {"No Old Settings found.", "Aucun ancien paramètre trouvé."},
                {"City Configuration", "Configuration de la ville"},
                {"Import Default Config", "Importer la configuration par défaut"},
                {
                    "This will import your Default City Customize Config. WARNING - This will overwrite all current values.",
                    "Cela importera votre configuration de personnalisation de la ville par défaut. AVERTISSEMENT - Cela écrasera toutes les valeurs actuelles."
                },
                {
                    "This option is only available in game and when Save Per City is enabled.",
                    "Cette option est uniquement disponible dans le jeu et lorsque Enregistrer par ville est activé."
                },
                {"Export Current City to Default", "Exporter la ville actuelle par défaut"},
                {
                    "This will export your Current City Customized Options to the Default Profile",
                    "Cela exportera vos options personnalisées de la ville actuelle vers le profil par défaut"
                },
                {"Définir comme nom par défaut ?", "Nom standard"},
                {"DISABLED", "DÉSACTIVÉ(E)"}
            };

            CitizenTranslations = new Dictionary<string, string>
            {
                {"Age", "Âge"},
                {"Age Group", "Tranche d'âge"},
                {"Crime Rate", "Taux de criminalité"},
                {"Criminal Status", "Statut de crime"},
                {"Education Level", "Niveau d'éducation"},
                {"Gender", "Sexe"},
                {"Happiness Level", "Niveau de bonheur"},
                {"Health Level", "Niveau de santé"},
                {"Income Rate", "Taux de revenu"},
                {"Job Title", "Profession"},
                {"Wealth Status", "Statut de richesse"},
                {"Wellbeing Level", "Niveau de bien-être"},
                {"Work Efficiency", "Éfficacité de travail"},
                {"Work Probability", "Probabilité de travail"}
            };

            Name = "French";
        }
    }
}
