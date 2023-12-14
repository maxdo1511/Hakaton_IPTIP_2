'use client'
import MainInfo from "@/components/profile/main-info";
import Rating from "@/components/profile/rating";
import Contacts from "@/components/profile/contacs";
import Subordinate from "@/components/profile/subordinate";
import config from "@/app/config";

export const userMainInfo = async () => {
    const res = await fetch(config.user_profile_main_info + "/example@edu-mirea.ru", {
        mode: 'no-cors', // попробовать убрать перед деплоем
        cache: "force-cache",
        next: {relative: 15}
    });
    if (res.ok) {
        const data = await res.json();
        return new Promise((resolve) => {
            setTimeout(() => {
                resolve(data);
            }, 500);
        });
    }
}

export default async function Profile() {
    const data = await userMainInfo();
    return (
        <div className={"profile bg-white"}>
            <div className={"MainInfo pb-4"}>
                <div className={"self-container grid grid-cols-3 gap-7 "}>
                    <MainInfo user_info={data}/>
                    <Contacts user_info={data}/>
                    <Rating ratings={data.rating}/>
                    {data.role === "teacher" &&
                        <Subordinate/>
                    }
                </div>
            </div>
        </div>
    )
}