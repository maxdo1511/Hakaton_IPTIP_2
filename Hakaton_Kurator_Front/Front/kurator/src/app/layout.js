import { Inter } from 'next/font/google'
import './globals.css'
import '../css/header.css'
import MainPage from "@/app/page";
import Header from "@/components/header";

const inter = Inter({ subsets: ['latin'] })

export const metadata = {
  title: 'Create Next App',
  description: 'Generated by create next app',
}

export default function RootLayout({ children }) {
  return (
    <html lang="ru">
      <body className={inter.className}>
          <header className={""}><Header /></header>
          <main className={""}>{children}</main >
          <footer className={""}></footer>
      </body>

    </html>
  )
}
