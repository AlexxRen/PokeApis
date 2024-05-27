using System.Security.Cryptography.X509Certificates;

namespace PokeApis.Resources.models;

public partial class ListadoPokemon : ContentPage
{
	public ListadoPokemon()
	{
		InitializeComponent();
	}
	public async void LoadData ()
	{
		PokemonApis _poke_apis = new PokemonApis();
		listado_pokemones = await _pokes_apis.DevuelveListadoPokemones();
		pokemonList.ItemsSource = listado_Pokemones;
	}
}