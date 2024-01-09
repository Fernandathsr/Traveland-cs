import Link from 'next/link'

export default function Header() {
	return (
		<header className="header">
			<img src="https://w7.pngwing.com/pngs/997/403/png-transparent-airplane-flight-fixed-wing-aircraft-airliner-airplane-photography-mode-of-transport-airplane.png" alt="logo" /> Traveland
			<ul>
				<li>
					<Link href="/RotaUm">Link 1</Link>
				</li>
				<li>
					<Link href="/RotaDois">Link 2</Link>
				</li>
				<li>
					<Link href="/RotaTres">Link 3</Link>
				</li>
			</ul>
		</header>
	)
}