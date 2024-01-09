import styles from './card.module.css';


export default async function Card() {
	const cards = await fetch('http://localhost:7098/api/Client').then(res => res.json());
	console.log(cards);

	return (
		<div className={styles.container}>
			{cards?.map((card) => (
				
				<div key={card.id} className={styles.card}>
					<img src="https://th.bing.com/th/id/OIP.NBGp_vtqZFgSh63pU1q6oQHaHa?rs=1&pid=ImgDetMain" alt={card.title}/>
					<div className={styles.card_title}>
						<p>{card.name}</p>
						<p>{card.city}</p>
					</div>
				</div>
			))}
		</div>
	)
}
