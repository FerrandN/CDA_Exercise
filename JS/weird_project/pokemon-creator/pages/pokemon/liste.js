import React from 'react';
import Image from 'next/image';
import Link from 'next/link';
export default class PokemonListe extends React.Component
{
    render()
    {
        return(
            <div>
            <h1>Liste des Pokemons</h1>
            <Image src="/image/PikaDrunk.jpg" 
            width={640}
            height={360}
            alt="photo de Pikachu"></Image>

            <Link href="dashboard">Dashboard</Link>
            </div>
        );
    }
}
// export default function PokemonListe()
// {
//     return
//     (
//         <h1>Liste des Pokemons</h1>
//     );
// }

